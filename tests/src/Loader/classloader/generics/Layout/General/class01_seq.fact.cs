using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Layout_General_class01_seq_class01_seq_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Layout_General_class01_seq_class01_seq_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Layout\\General\\class01_seq\\class01_seq.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
