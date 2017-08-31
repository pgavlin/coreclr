using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _CheckedCtor_Test_CSharp_Base_3_Test_CSharp_Base_3_
    {
        [OuterLoop]
        [Fact]
        public void _CheckedCtor_Test_CSharp_Base_3_Test_CSharp_Base_3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\CheckedCtor\\Test_CSharp_Base_3\\Test_CSharp_Base_3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
