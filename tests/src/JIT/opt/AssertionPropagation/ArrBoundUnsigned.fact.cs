using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _AssertionPropagation_ArrBoundUnsigned_ArrBoundUnsigned_
    {
        [Fact]
        public void _AssertionPropagation_ArrBoundUnsigned_ArrBoundUnsigned_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\AssertionPropagation\\ArrBoundUnsigned\\ArrBoundUnsigned.cmd");
        }
    }
}
