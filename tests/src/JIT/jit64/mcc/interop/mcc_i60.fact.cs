using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _mcc_interop_mcc_i60_mcc_i60_
    {
        [ActiveIssue("needs triage")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _mcc_interop_mcc_i60_mcc_i60_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\mcc\\interop\\mcc_i60\\mcc_i60.cmd");
        }
    }
}
