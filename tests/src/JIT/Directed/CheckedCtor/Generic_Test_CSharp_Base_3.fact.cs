using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _CheckedCtor_Generic_Test_CSharp_Base_3_Generic_Test_CSharp_Base_3_
    {
        [OuterLoop]
        [Fact]
        public void _CheckedCtor_Generic_Test_CSharp_Base_3_Generic_Test_CSharp_Base_3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\CheckedCtor\\Generic_Test_CSharp_Base_3\\Generic_Test_CSharp_Base_3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
