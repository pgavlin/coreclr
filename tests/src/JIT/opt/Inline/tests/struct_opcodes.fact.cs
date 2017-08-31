using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Inline_tests_struct_opcodes_struct_opcodes_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_struct_opcodes_struct_opcodes_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\struct_opcodes\\struct_opcodes.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
