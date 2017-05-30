using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ninject
{
    public class ReaderWriterLock : IDisposable
    {
        private readonly ReaderWriterLockSlim _locker;

        public ReaderWriterLock(
            )
        {
            _locker = new ReaderWriterLockSlim(LockRecursionPolicy.SupportsRecursion);
        }

        public void UpgradeToWriterLock(int timeout)
        {
            if (timeout == System.Threading.Timeout.Infinite)
            {
                _locker.EnterWriteLock();
            }
            else
            {
                var result = _locker.TryEnterWriteLock(timeout);

                if (!result)
                {
                    throw new TimeoutException("UpgradeToWriterLock timeout");
                }
            }
        }

        public void DowngradeFromWriterLock()
        {
            _locker.ExitWriteLock();
        }




        public void AcquireUpgradableReaderLock(int timeout)
        {
            if (timeout == System.Threading.Timeout.Infinite)
            {
                _locker.EnterUpgradeableReadLock();
            }
            else
            {
                var result = _locker.TryEnterUpgradeableReadLock(timeout);

                if (!result)
                {
                    throw new TimeoutException("AcquireUpgradableReaderLock timeout");
                }
            }
        }

        public void ReleaseUpgradableReaderLock()
        {
            _locker.ExitUpgradeableReadLock();
        }





        public void AcquireTrueReaderLock(int timeout)
        {
            if (timeout == System.Threading.Timeout.Infinite)
            {
                _locker.EnterReadLock();
            }
            else
            {
                var result = _locker.TryEnterReadLock(timeout);

                if (!result)
                {
                    throw new TimeoutException("AcquireReaderLock timeout");
                }
            }
        }

        public void ReleaseTrueReaderLock()
        {
            _locker.ExitReadLock();
        }





        
        public void AcquireWriterLock(int timeout)
        {
            if (timeout == System.Threading.Timeout.Infinite)
            {
                _locker.EnterWriteLock();
            }
            else
            {
                var result = _locker.TryEnterWriteLock(timeout);

                if (!result)
                {
                    throw new TimeoutException("AcquireWriterLock timeout");
                }
            }
        }

        public void ReleaseWriterLock()
        {
            _locker.ExitWriteLock();
        }





        public void Dispose()
        {
            _locker.Dispose();
        }
    }

}