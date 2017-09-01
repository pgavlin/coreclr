using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    public class _GCHandle_Equality_Equality_
    {
        [OuterLoop]
        [Fact]
        public void _GCHandle_Equality_Equality_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\API\\GCHandle\\Equality\\Equality.cmd");
        }
    }
}
