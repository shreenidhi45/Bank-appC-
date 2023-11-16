using FinalProject.DTOx;
using FinalProject.Models;

namespace FinalProject.Service
{
    public interface ITransactionService
    {
        public void MakeDeposit(TransactionDto transactionDto, TransactionType Deposit);
        public void MakeWithdrawal(TransactionDto transactionDto, TransactionType withdrawal);
        public void MakeTransfer(TransferDto transferDto, TransactionType transfer);
        //public void MakeDeposit(DepositDto depositDto);
        //public void MakeWithdrawal(TransactionDto transactionDto);
        //public void MakeTransfer(TransferDto transferDto);
    }
}
