using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _stringintern__XModuletest2_xmod__XModuletest2_xmod_
    {
        [OuterLoop]
        [Fact]
        public void _stringintern__XModuletest2_xmod__XModuletest2_xmod_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\stringintern\\_XModuletest2-xmod\\_XModuletest2-xmod.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
