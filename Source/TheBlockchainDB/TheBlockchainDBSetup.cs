using System;
using System.Collections.Generic;
using Blockcore.Consensus.Checkpoints;
using TheBlockchainDB.Networks;
using TheBlockchainDB.Networks.Setup;
using Blockcore.NBitcoin;

namespace TheBlockchainDB
{
   internal class TheBlockchainDBSetup
   {
      internal static TheBlockchainDBSetup Instance = new TheBlockchainDBSetup();

      internal CoinSetup Setup = new CoinSetup
      {
         FileNamePrefix = "",
         ConfigFileName = ".conf",
         Magic = "41-27-41-27",
         CoinType = 4127, // SLIP-0044: https://github.com/satoshilabs/slips/blob/master/slip-0044.md,
         PremineReward = 1000000,
         PoWBlockReward = 10,
         PoSBlockReward = 10,
         LastPowBlock = 25000,
         GenesisText = "Data should be a free asset for everyone", // The New York Times, 2020-04-16
         TargetSpacing = TimeSpan.FromSeconds(64),
         ProofOfStakeTimestampMask = 0x0000000F, // 0x0000003F // 64 sec
         PoSVersion = 3
      };

      internal NetworkSetup Main = new NetworkSetup
      {
         Name = "TheBlockchainDBMain",
         RootFolderName = "",
         CoinTicker = "BDB",
         DefaultPort = 41271,
         DefaultRPCPort = 41272,
         DefaultAPIPort = 41273,
         PubKeyAddress = 25, // B https://en.bitcoin.it/wiki/List_of_address_prefixes
         ScriptAddress = 125, // b
         SecretAddress = 117,
         GenesisTime = 1706568919,
         GenesisNonce = 129283,
         GenesisBits = 0x1E0FFFFF,
         GenesisVersion = 1,
         GenesisReward = Money.Zero,
         HashGenesisBlock = "000006e8f2a2e2eae539a2e9c782c372cdba0cc4d03923144a2edda3beaf7582",
         HashMerkleRoot = "14db9110295464d9a6c6760893ccd9ccf41489c691d0cd29afcdab1ed8ef4a41",
         DNS = new[] { "seed1.theblockchaindb.net", "seed2.theblockchaindb.net", "bdb.seed.blockcore.net" },
         Nodes = new[] { "20.203.218.206", "89.217.169.40" },
         Checkpoints = new Dictionary<int, CheckpointInfo>
         {
            // TODO: Add checkpoints as the network progresses.
         }
      };

      internal NetworkSetup RegTest = new NetworkSetup
      {
         Name = "TheBlockchainDBRegTest",
         RootFolderName = "regtest",
         CoinTicker = "TBDB",
         DefaultPort = 41281,
         DefaultRPCPort = 41282,
         DefaultAPIPort = 41283,
         PubKeyAddress = 111,
         ScriptAddress = 196,
         SecretAddress = 239,
         GenesisTime = 1706568927,
         GenesisNonce = 388227,
         GenesisBits = 0x1F00FFFF,
         GenesisVersion = 1,
         GenesisReward = Money.Zero,
         HashGenesisBlock = "000095f3ddf51c5ce3cb6ee13a526fb2b3f90af9c9d9867d4b108da98096ced4",
         HashMerkleRoot = "1be118dbd8244fba981c4a7fed514ece2f423e27ea931525921ea132b9f2ae69",
         DNS = new[] { "seedregtest1.bdb.blockcore.net", "seedregtest2.bdb.blockcore.net", "seedregtest.bdb.blockcore.net" },
         Nodes = new[] { "20.203.218.206", "89.217.169.40" },
         Checkpoints = new Dictionary<int, CheckpointInfo>
         {
            // TODO: Add checkpoints as the network progresses.
         }
      };

      internal NetworkSetup Test = new NetworkSetup
      {
         Name = "TheBlockchainDBTest",
         RootFolderName = "test",
         CoinTicker = "TBDB",
         DefaultPort = 41291,
         DefaultRPCPort = 41292,
         DefaultAPIPort = 41293,
         PubKeyAddress = 111,
         ScriptAddress = 196,
         SecretAddress = 239,
         GenesisTime = 1706568951,
         GenesisNonce = 771,
         GenesisBits = 0x1F0FFFFF,
         GenesisVersion = 1,
         GenesisReward = Money.Zero,
         HashGenesisBlock = "00065a26c8c4695d1df7a54148dd03ccbe0d1070180edb211afaf26dc2cd929f",
         HashMerkleRoot = "3f926bc83c29cfc186a2b8662a4e9fe4cf97722e45de1890ab2306ac219a75c1",
         DNS = new[] { "seedtest1.bdb.blockcore.net", "seedtest2.bdb.blockcore.net", "seedtest.bdb.blockcore.net" },
         Nodes = new[] { "20.203.218.206", "89.217.169.40" },
         Checkpoints = new Dictionary<int, CheckpointInfo>
         {
            // TODO: Add checkpoints as the network progresses.
         }
      };

      public bool IsPoSv3()
      {
         return Setup.PoSVersion == 3;
      }

      public bool IsPoSv4()
      {
         return Setup.PoSVersion == 4;
      }
   }
}
