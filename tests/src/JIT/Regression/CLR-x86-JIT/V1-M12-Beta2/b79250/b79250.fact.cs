using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _CLR_x86_JIT_V1_M12_Beta2_b79250_b79250_b79250_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [Fact]
        public void _CLR_x86_JIT_V1_M12_Beta2_b79250_b79250_b79250_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1-M12-Beta2\\b79250\\b79250\\b79250.cmd");
        }
    }
}
