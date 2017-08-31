using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_ctor__il_dbgval_ctor_newobj__il_dbgval_ctor_newobj_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_ctor__il_dbgval_ctor_newobj__il_dbgval_ctor_newobj_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\ctor\\_il_dbgval_ctor_newobj\\_il_dbgval_ctor_newobj.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
