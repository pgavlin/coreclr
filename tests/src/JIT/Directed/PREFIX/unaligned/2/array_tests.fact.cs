using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _PREFIX_unaligned_2_array_tests_array_tests_
    {
        [OuterLoop]
        [Fact]
        public void _PREFIX_unaligned_2_array_tests_array_tests_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\PREFIX\\unaligned\\2\\array_tests\\array_tests.cmd");
        }
    }
}
