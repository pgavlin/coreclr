using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_ctor__il_relval_ctor_newobj__il_relval_ctor_newobj_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_ctor__il_relval_ctor_newobj__il_relval_ctor_newobj_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\ctor\\_il_relval_ctor_newobj\\_il_relval_ctor_newobj.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
