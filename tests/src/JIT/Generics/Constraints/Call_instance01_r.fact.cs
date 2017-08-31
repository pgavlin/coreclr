using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Constraints_Call_instance01_r_Call_instance01_r_
    {
        [OuterLoop]
        [Fact]
        public void _Constraints_Call_instance01_r_Call_instance01_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Constraints\\Call_instance01_r\\Call_instance01_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
