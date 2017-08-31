using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _xxobj_ldobj__il_dbgldobj_U2__il_dbgldobj_U2_
    {
        [OuterLoop]
        [Fact]
        public void _xxobj_ldobj__il_dbgldobj_U2__il_dbgldobj_U2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\xxobj\\ldobj\\_il_dbgldobj_U2\\_il_dbgldobj_U2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
