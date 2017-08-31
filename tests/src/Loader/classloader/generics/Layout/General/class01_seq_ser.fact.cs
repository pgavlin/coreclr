using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Layout_General_class01_seq_ser_class01_seq_ser_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Layout_General_class01_seq_ser_class01_seq_ser_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Layout\\General\\class01_seq_ser\\class01_seq_ser.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
