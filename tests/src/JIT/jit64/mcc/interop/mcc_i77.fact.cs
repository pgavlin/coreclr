using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _mcc_interop_mcc_i77_mcc_i77_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [Fact]
        public void _mcc_interop_mcc_i77_mcc_i77_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\mcc\\interop\\mcc_i77\\mcc_i77.cmd");
        }
    }
}
