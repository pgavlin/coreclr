using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Layout_General_Base01a_seq_Base01a_seq_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Layout_General_Base01a_seq_Base01a_seq_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Layout\\General\\Base01a_seq\\Base01a_seq.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
