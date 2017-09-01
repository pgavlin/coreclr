using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _xxobj_operand_refanyval_refanyval_
    {
        [OuterLoop]
        [Fact]
        public void _xxobj_operand_refanyval_refanyval_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\xxobj\\operand\\refanyval\\refanyval.cmd");
        }
    }
}
