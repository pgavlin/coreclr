using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    public class _GCHandle_Free_neg_Free_neg_
    {
        [Fact]
        public void _GCHandle_Free_neg_Free_neg_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\API\\GCHandle\\Free_neg\\Free_neg.cmd");
        }
    }
}
