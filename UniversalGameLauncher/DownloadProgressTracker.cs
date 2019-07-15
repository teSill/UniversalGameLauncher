using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalGameLauncher {
    public class DownloadProgressTracker {

        private long _totalFileSize;
        private readonly int _sampleSize;
        private readonly TimeSpan _valueDelay;

        private DateTime _lastUpdateCalculated;
        private long _previousProgress;

        private double _cachedSpeed;

        private Queue<Tuple<DateTime, long>> _changes = new Queue<Tuple<DateTime, long>>();

        public DownloadProgressTracker(int sampleSize, TimeSpan valueDelay) {
            _lastUpdateCalculated = DateTime.Now;
            _sampleSize = sampleSize;
            _valueDelay = valueDelay;
        }

        public void Reset() {
            _previousProgress = 0;
        }

        public void SetProgress(long bytesReceived, long totalBytesToReceive) {
            _totalFileSize = totalBytesToReceive;

            long diff = bytesReceived - _previousProgress;
            if (diff <= 0)
                return;

            _previousProgress = bytesReceived;

            _changes.Enqueue(new Tuple<DateTime, long>(DateTime.Now, diff));
            while (_changes.Count > _sampleSize)
                _changes.Dequeue();
        }

        public double GetProgress() {
            return _previousProgress / (double) _totalFileSize;
        }

        public string GetProgressString() {
            return String.Format("{0:P0}", GetProgress());
        }

        public string GetBytesPerSecondString() {
            double speed = GetBytesPerSecond();
            var prefix = new[] { "", "K", "M", "G"};

            int index = 0;
            while (speed > 1024 && index < prefix.Length - 1)
            {
                speed /= 1024;
                index++;
            }

            int intLen = ((int) speed).ToString().Length;
            int decimals = 3 - intLen;
            if (decimals < 0)
                decimals = 0;

            string format = String.Format("{{0:F{0}}}", decimals) + "{1}B/s";

            return String.Format(format, speed, prefix[index]);
        }

        public double GetBytesPerSecond() {
            if (DateTime.Now >= _lastUpdateCalculated + _valueDelay) {
                _lastUpdateCalculated = DateTime.Now;
                _cachedSpeed = GetRateInternal();
            }

            return _cachedSpeed;
        }

        private double GetRateInternal() {
            if (_changes.Count == 0)
                return 0;

            TimeSpan timespan = _changes.Last().Item1 - _changes.First().Item1;
            long bytes = _changes.Sum(t => t.Item2);

            double rate = bytes / timespan.TotalSeconds;

            if (double.IsInfinity(rate) || double.IsNaN(rate))
                return 0;

            return rate;
        }
    }
}
