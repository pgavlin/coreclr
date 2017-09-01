using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _mcc_interop_mcc_i12_mcc_i12_
    {
        [ActiveIssue("needs triage")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _mcc_interop_mcc_i12_mcc_i12_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\mcc\\interop\\mcc_i12\\mcc_i12.cmd");
        }
    }
}
