using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _AssertionPropagation_ArrBoundUnsigned_ArrBoundUnsigned_
    {
        [Fact]
        public void _AssertionPropagation_ArrBoundUnsigned_ArrBoundUnsigned_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\AssertionPropagation\\ArrBoundUnsigned\\ArrBoundUnsigned.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
