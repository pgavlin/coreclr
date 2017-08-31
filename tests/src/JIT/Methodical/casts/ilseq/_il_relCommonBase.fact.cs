using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_ilseq__il_relCommonBase__il_relCommonBase_
    {
        [OuterLoop]
        [Fact]
        public void _casts_ilseq__il_relCommonBase__il_relCommonBase_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\ilseq\\_il_relCommonBase\\_il_relCommonBase.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
