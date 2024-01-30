using Blockcore.Networks;

namespace TheBlockchainDB.Networks
{
   public static class Networks
   {
      public static NetworksSelector TheBlockchainDB
      {
         get
         {
            return new NetworksSelector(() => new TheBlockchainDBMain(), () => new TheBlockchainDBTest(), () => new TheBlockchainDBRegTest());
         }
      }
   }
}
