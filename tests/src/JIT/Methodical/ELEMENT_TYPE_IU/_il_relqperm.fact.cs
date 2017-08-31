using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _ELEMENT_TYPE_IU__il_relqperm__il_relqperm_
    {
        [OuterLoop]
        [Fact]
        public void _ELEMENT_TYPE_IU__il_relqperm__il_relqperm_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\ELEMENT_TYPE_IU\\_il_relqperm\\_il_relqperm.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
