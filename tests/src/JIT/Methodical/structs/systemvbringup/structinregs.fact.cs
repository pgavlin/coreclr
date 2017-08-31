using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _structs_systemvbringup_structinregs_structinregs_
    {
        [OuterLoop]
        [Fact]
        public void _structs_systemvbringup_structinregs_structinregs_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\structs\\systemvbringup\\structinregs\\structinregs.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
