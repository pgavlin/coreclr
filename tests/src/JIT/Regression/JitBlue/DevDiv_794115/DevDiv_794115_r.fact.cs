using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _JitBlue_DevDiv_794115_DevDiv_794115_r_DevDiv_794115_r_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_DevDiv_794115_DevDiv_794115_r_DevDiv_794115_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_794115\\DevDiv_794115_r\\DevDiv_794115_r.cmd");
        }
    }
}
