using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _Inline_tests_struct_opcodes_struct_opcodes_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_struct_opcodes_struct_opcodes_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\struct_opcodes\\struct_opcodes.cmd");
        }
    }
}
