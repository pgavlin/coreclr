using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _CheckedCtor_Test_CSharp_Base_4_Test_CSharp_Base_4_
    {
        [OuterLoop]
        [Fact]
        public void _CheckedCtor_Test_CSharp_Base_4_Test_CSharp_Base_4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\CheckedCtor\\Test_CSharp_Base_4\\Test_CSharp_Base_4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
