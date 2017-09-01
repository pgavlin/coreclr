using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _mcc_interop_mcc_i14_mcc_i14_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _mcc_interop_mcc_i14_mcc_i14_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\mcc\\interop\\mcc_i14\\mcc_i14.cmd");
        }
    }
}
