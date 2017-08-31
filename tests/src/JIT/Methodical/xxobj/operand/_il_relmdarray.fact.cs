using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _xxobj_operand__il_relmdarray__il_relmdarray_
    {
        [OuterLoop]
        [Fact]
        public void _xxobj_operand__il_relmdarray__il_relmdarray_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\xxobj\\operand\\_il_relmdarray\\_il_relmdarray.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
