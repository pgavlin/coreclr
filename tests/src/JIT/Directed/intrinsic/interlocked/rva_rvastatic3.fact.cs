using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _intrinsic_interlocked_rva_rvastatic3_rva_rvastatic3_
    {
        [ActiveIssue("2451")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _intrinsic_interlocked_rva_rvastatic3_rva_rvastatic3_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\intrinsic\\interlocked\\rva_rvastatic3\\rva_rvastatic3.cmd");
        }
    }
}
