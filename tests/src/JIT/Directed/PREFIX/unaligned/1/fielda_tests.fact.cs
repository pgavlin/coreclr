using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _PREFIX_unaligned_1_fielda_tests_fielda_tests_
    {
        [OuterLoop]
        [Fact]
        public void _PREFIX_unaligned_1_fielda_tests_fielda_tests_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\PREFIX\\unaligned\\1\\fielda_tests\\fielda_tests.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
