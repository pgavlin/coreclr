using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _mcc_interop_mcc_i51_mcc_i51_
    {
        [ActiveIssue("needs triage")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _mcc_interop_mcc_i51_mcc_i51_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\mcc\\interop\\mcc_i51\\mcc_i51.cmd");
        }
    }
}
