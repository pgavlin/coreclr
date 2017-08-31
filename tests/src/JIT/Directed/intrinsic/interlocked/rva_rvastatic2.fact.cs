using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _intrinsic_interlocked_rva_rvastatic2_rva_rvastatic2_
    {
        [ActiveIssue("2451")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _intrinsic_interlocked_rva_rvastatic2_rva_rvastatic2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\intrinsic\\interlocked\\rva_rvastatic2\\rva_rvastatic2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
