using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _PREFIX_unaligned_2_field_tests_field_tests_
    {
        [OuterLoop]
        [Fact]
        public void _PREFIX_unaligned_2_field_tests_field_tests_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\PREFIX\\unaligned\\2\\field_tests\\field_tests.cmd");
        }
    }
}
