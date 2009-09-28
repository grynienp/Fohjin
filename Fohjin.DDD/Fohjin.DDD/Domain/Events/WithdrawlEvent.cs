using System;
using Fohjin.DDD.Domain.ValueObjects;

namespace Fohjin.DDD.Domain.Events
{
    public class WithdrawlEvent : IDomainEvent
    {
        public WithdrawlEvent(Balance balance, Amount amount)
        {
            TimeStamp = DateTime.Now.Ticks;
            Balance = balance;
            Amount = amount;
        }
        public long TimeStamp { get; private set; }
        public Balance Balance { get; private set; }
        public Amount Amount { get; private set; }
    }
}