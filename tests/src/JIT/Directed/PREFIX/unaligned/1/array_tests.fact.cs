using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _PREFIX_unaligned_1_array_tests_array_tests_
    {
        [OuterLoop]
        [Fact]
        public void _PREFIX_unaligned_1_array_tests_array_tests_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\PREFIX\\unaligned\\1\\array_tests\\array_tests.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
