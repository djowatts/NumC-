using System.Linq;
using Xunit;

namespace NumCSharp.Domain.Tests.NdArray
{
    public class NdArrayTests
    {
        [Fact]
        public void GeneratingAnIntNdArrayOfZeros()
        {
            var arr = NumCSharp.Domain.NdArray<int>.OfZeros(1, 3);

            Assert.True(arr.GetValue(0) is int);
            Assert.True(arr.Length == 3);

            for (var i = 0; i < arr.Length; i++)
            {
                Assert.Equal(0, arr.GetValue(i));
            }
        }
    }
}
