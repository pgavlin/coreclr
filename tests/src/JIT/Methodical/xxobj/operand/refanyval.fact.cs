using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _xxobj_operand_refanyval_refanyval_
    {
        [OuterLoop]
        [Fact]
        public void _xxobj_operand_refanyval_refanyval_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\xxobj\\operand\\refanyval\\refanyval.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
