using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _CheckedCtor_Generic_Test_CSharp_Base_2_Generic_Test_CSharp_Base_2_
    {
        [OuterLoop]
        [Fact]
        public void _CheckedCtor_Generic_Test_CSharp_Base_2_Generic_Test_CSharp_Base_2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\CheckedCtor\\Generic_Test_CSharp_Base_2\\Generic_Test_CSharp_Base_2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
