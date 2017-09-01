using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _intrinsic_interlocked_rva_rvastatic1_rva_rvastatic1_
    {
        [ActiveIssue("2451")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _intrinsic_interlocked_rva_rvastatic1_rva_rvastatic1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\intrinsic\\interlocked\\rva_rvastatic1\\rva_rvastatic1.cmd");
        }
    }
}
