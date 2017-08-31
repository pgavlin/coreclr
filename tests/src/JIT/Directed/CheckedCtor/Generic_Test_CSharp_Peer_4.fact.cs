using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _CheckedCtor_Generic_Test_CSharp_Peer_4_Generic_Test_CSharp_Peer_4_
    {
        [OuterLoop]
        [Fact]
        public void _CheckedCtor_Generic_Test_CSharp_Peer_4_Generic_Test_CSharp_Peer_4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\CheckedCtor\\Generic_Test_CSharp_Peer_4\\Generic_Test_CSharp_Peer_4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
