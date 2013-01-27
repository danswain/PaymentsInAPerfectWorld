﻿using Pop3;

namespace Penny
{
    public class MailTranslator
    {
        private readonly IListenForOrders _orderListener;

        public MailTranslator(IListenForOrders orderListener)
        {
            _orderListener = orderListener;
        }

        public void Process(OrderMessage mailMessage)
        {
            _orderListener.OrderReceived(mailMessage.From);
        }
    }
}