using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _intrinsic_interlocked_rva_rvastatic4_rva_rvastatic4_
    {
        [ActiveIssue("2451")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _intrinsic_interlocked_rva_rvastatic4_rva_rvastatic4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\intrinsic\\interlocked\\rva_rvastatic4\\rva_rvastatic4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
