using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    public class _GC_SuppressFinalize_SuppressFinalize_
    {
        [OuterLoop]
        [Fact]
        public void _GC_SuppressFinalize_SuppressFinalize_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\API\\GC\\SuppressFinalize\\SuppressFinalize.cmd");
        }
    }
}
