using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Arrays_misc__il_dbginitializearray_enum__il_dbginitializearray_enum_
    {
        [OuterLoop]
        [Fact]
        public void _Arrays_misc__il_dbginitializearray_enum__il_dbginitializearray_enum_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Arrays\\misc\\_il_dbginitializearray_enum\\_il_dbginitializearray_enum.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
