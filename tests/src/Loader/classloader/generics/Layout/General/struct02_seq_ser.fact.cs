using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Layout_General_struct02_seq_ser_struct02_seq_ser_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Layout_General_struct02_seq_ser_struct02_seq_ser_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Layout\\General\\struct02_seq_ser\\struct02_seq_ser.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
