using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Layout_General_Base01d_seq_ser_Base01d_seq_ser_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Layout_General_Base01d_seq_ser_Base01d_seq_ser_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Layout\\General\\Base01d_seq_ser\\Base01d_seq_ser.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
