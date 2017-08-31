using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _CheckedCtor_Generic_Test_CSharp_Base_6_Generic_Test_CSharp_Base_6_
    {
        [OuterLoop]
        [Fact]
        public void _CheckedCtor_Generic_Test_CSharp_Base_6_Generic_Test_CSharp_Base_6_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\CheckedCtor\\Generic_Test_CSharp_Base_6\\Generic_Test_CSharp_Base_6.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
