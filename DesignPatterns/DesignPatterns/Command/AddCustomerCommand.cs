﻿using System.Runtime.CompilerServices;

namespace DesignPatterns.Command
{
    internal class AddCustomerCommand : ICommand
    {
        private CustomerService _customerService;
        public AddCustomerCommand(CustomerService customerService)
        {
            _customerService = customerService;
        }
        public void Execute()
        {
            _customerService.addCustomer();
        }
    }
}