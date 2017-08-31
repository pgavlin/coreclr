using CoreclrTestLib;
using Xunit;

namespace baseservices_compilerservices
{
    class _RuntimeHelpers_ExecuteCodeWithGuaranteedCleanup_ExecuteCodeWithGuaranteedCleanup_
    {
        [OuterLoop]
        [Fact]
        public void _RuntimeHelpers_ExecuteCodeWithGuaranteedCleanup_ExecuteCodeWithGuaranteedCleanup_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\compilerservices\\RuntimeHelpers\\ExecuteCodeWithGuaranteedCleanup\\ExecuteCodeWithGuaranteedCleanup.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
