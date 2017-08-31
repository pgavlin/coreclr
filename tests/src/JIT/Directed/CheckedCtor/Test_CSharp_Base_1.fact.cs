using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _CheckedCtor_Test_CSharp_Base_1_Test_CSharp_Base_1_
    {
        [OuterLoop]
        [Fact]
        public void _CheckedCtor_Test_CSharp_Base_1_Test_CSharp_Base_1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\CheckedCtor\\Test_CSharp_Base_1\\Test_CSharp_Base_1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
