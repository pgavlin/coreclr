using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _mcc_interop_mcc_i54_mcc_i54_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _mcc_interop_mcc_i54_mcc_i54_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\mcc\\interop\\mcc_i54\\mcc_i54.cmd");
        }
    }
}
