using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Constraints_Call_instance01_ro_Call_instance01_ro_
    {
        [OuterLoop]
        [Fact]
        public void _Constraints_Call_instance01_ro_Call_instance01_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Constraints\\Call_instance01_ro\\Call_instance01_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
