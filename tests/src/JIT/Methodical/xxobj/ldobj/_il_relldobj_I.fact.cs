using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _xxobj_ldobj__il_relldobj_I__il_relldobj_I_
    {
        [OuterLoop]
        [Fact]
        public void _xxobj_ldobj__il_relldobj_I__il_relldobj_I_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\xxobj\\ldobj\\_il_relldobj_I\\_il_relldobj_I.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
