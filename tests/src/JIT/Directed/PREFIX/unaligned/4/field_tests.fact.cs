using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _PREFIX_unaligned_4_field_tests_field_tests_
    {
        [OuterLoop]
        [Fact]
        public void _PREFIX_unaligned_4_field_tests_field_tests_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\PREFIX\\unaligned\\4\\field_tests\\field_tests.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
