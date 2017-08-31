using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _ELEMENT_TYPE_IU__il_dbgi_seq__il_dbgi_seq_
    {
        [OuterLoop]
        [Fact]
        public void _ELEMENT_TYPE_IU__il_dbgi_seq__il_dbgi_seq_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\ELEMENT_TYPE_IU\\_il_dbgi_seq\\_il_dbgi_seq.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
